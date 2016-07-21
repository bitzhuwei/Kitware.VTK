using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorEventRecorder : vtkInteractorObserver
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorEventRecorder";

		public new static readonly string MRClassNameKey;

		static vtkInteractorEventRecorder()
		{
			vtkInteractorEventRecorder.MRClassNameKey = "class vtkInteractorEventRecorder";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorEventRecorder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorEventRecorder"));
		}

		public vtkInteractorEventRecorder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorEventRecorder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorEventRecorder New()
		{
			vtkInteractorEventRecorder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorEventRecorder.vtkInteractorEventRecorder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorEventRecorder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorEventRecorder.vtkInteractorEventRecorder_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorEventRecorder_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorEventRecorder_GetInputString_02(HandleRef pThis);

		public virtual string GetInputString()
		{
			return Marshal.PtrToStringAnsi(vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetInputString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorEventRecorder_GetReadFromInputString_03(HandleRef pThis);

		public virtual int GetReadFromInputString()
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetReadFromInputString_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorEventRecorder_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorEventRecorder_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorEventRecorder_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorEventRecorder NewInstance()
		{
			vtkInteractorEventRecorder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorEventRecorder.vtkInteractorEventRecorder_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_Play_08(HandleRef pThis);

		public void Play()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Play_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_ReadFromInputStringOff_09(HandleRef pThis);

		public virtual void ReadFromInputStringOff()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_ReadFromInputStringOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_ReadFromInputStringOn_10(HandleRef pThis);

		public virtual void ReadFromInputStringOn()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_ReadFromInputStringOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_Record_11(HandleRef pThis);

		public void Record()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Record_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_Rewind_12(HandleRef pThis);

		public void Rewind()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Rewind_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorEventRecorder_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorEventRecorder SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorEventRecorder vtkInteractorEventRecorder = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorEventRecorder.vtkInteractorEventRecorder_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorEventRecorder = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorEventRecorder.Register(null);
				}
			}
			return vtkInteractorEventRecorder;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_SetEnabled_14(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetEnabled_14(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_SetFileName_15(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetFileName_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_SetInputString_16(HandleRef pThis, string _arg);

		public virtual void SetInputString(string _arg)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetInputString_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_SetInteractor_17(HandleRef pThis, HandleRef iren);

		public override void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetInteractor_17(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_SetReadFromInputString_18(HandleRef pThis, int _arg);

		public virtual void SetReadFromInputString(int _arg)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetReadFromInputString_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorEventRecorder_Stop_19(HandleRef pThis);

		public void Stop()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Stop_19(base.GetCppThis());
		}
	}
}
