using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkView : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkView";

		public new static readonly string MRClassNameKey;

		static vtkView()
		{
			vtkView.MRClassNameKey = "class vtkView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkView"));
		}

		public vtkView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkView New()
		{
			vtkView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkView.vtkView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_AddRepresentation_01(HandleRef pThis, HandleRef rep);

		public void AddRepresentation(vtkDataRepresentation rep)
		{
			vtkView.vtkView_AddRepresentation_01(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_AddRepresentationFromInput_02(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation AddRepresentationFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_AddRepresentationFromInput_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_AddRepresentationFromInputConnection_03(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation AddRepresentationFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_AddRepresentationFromInputConnection_03(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_ApplyViewTheme_04(HandleRef pThis, HandleRef arg0);

		public virtual void ApplyViewTheme(vtkViewTheme arg0)
		{
			vtkView.vtkView_ApplyViewTheme_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkView_GetNumberOfRepresentations_05(HandleRef pThis);

		public int GetNumberOfRepresentations()
		{
			return vtkView.vtkView_GetNumberOfRepresentations_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_GetObserver_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCommand GetObserver()
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_GetObserver_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_GetRepresentation_07(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation GetRepresentation(int index)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_GetRepresentation_07(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkView_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkView.vtkView_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkView_IsRepresentationPresent_09(HandleRef pThis, HandleRef rep);

		public bool IsRepresentationPresent(vtkDataRepresentation rep)
		{
			return vtkView.vtkView_IsRepresentationPresent_09(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkView_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkView.vtkView_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkView NewInstance()
		{
			vtkView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_RegisterProgress_13(HandleRef pThis, HandleRef algorithm, string message);

		public void RegisterProgress(vtkObject algorithm, string message)
		{
			vtkView.vtkView_RegisterProgress_13(base.GetCppThis(), (algorithm == null) ? default(HandleRef) : algorithm.GetCppThis(), message);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_RemoveAllRepresentations_14(HandleRef pThis);

		public void RemoveAllRepresentations()
		{
			vtkView.vtkView_RemoveAllRepresentations_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_RemoveRepresentation_15(HandleRef pThis, HandleRef rep);

		public void RemoveRepresentation(vtkDataRepresentation rep)
		{
			vtkView.vtkView_RemoveRepresentation_15(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_RemoveRepresentation_16(HandleRef pThis, HandleRef rep);

		public void RemoveRepresentation(vtkAlgorithmOutput rep)
		{
			vtkView.vtkView_RemoveRepresentation_16(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkView SafeDownCast(vtkObjectBase o)
		{
			vtkView vtkView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkView = (vtkView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkView.Register(null);
				}
			}
			return vtkView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_SetRepresentation_18(HandleRef pThis, HandleRef rep);

		public void SetRepresentation(vtkDataRepresentation rep)
		{
			vtkView.vtkView_SetRepresentation_18(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_SetRepresentationFromInput_19(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetRepresentationFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_SetRepresentationFromInput_19(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkView_SetRepresentationFromInputConnection_20(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataRepresentation SetRepresentationFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkView.vtkView_SetRepresentationFromInputConnection_20(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_UnRegisterProgress_21(HandleRef pThis, HandleRef algorithm);

		public void UnRegisterProgress(vtkObject algorithm)
		{
			vtkView.vtkView_UnRegisterProgress_21(base.GetCppThis(), (algorithm == null) ? default(HandleRef) : algorithm.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkView_Update_22(HandleRef pThis);

		public virtual void Update()
		{
			vtkView.vtkView_Update_22(base.GetCppThis());
		}
	}
}
