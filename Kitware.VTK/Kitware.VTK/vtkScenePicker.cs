using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkScenePicker : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkScenePicker";

		public new static readonly string MRClassNameKey;

		static vtkScenePicker()
		{
			vtkScenePicker.MRClassNameKey = "class vtkScenePicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScenePicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScenePicker"));
		}

		public vtkScenePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScenePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScenePicker New()
		{
			vtkScenePicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkScenePicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkScenePicker.vtkScenePicker_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScenePicker_EnableVertexPickingOff_01(HandleRef pThis);

		public virtual void EnableVertexPickingOff()
		{
			vtkScenePicker.vtkScenePicker_EnableVertexPickingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScenePicker_EnableVertexPickingOn_02(HandleRef pThis);

		public virtual void EnableVertexPickingOn()
		{
			vtkScenePicker.vtkScenePicker_EnableVertexPickingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkScenePicker_GetCellId_03(HandleRef pThis, IntPtr displayPos);

		public long GetCellId(IntPtr displayPos)
		{
			return vtkScenePicker.vtkScenePicker_GetCellId_03(base.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScenePicker_GetEnableVertexPicking_04(HandleRef pThis);

		public virtual int GetEnableVertexPicking()
		{
			return vtkScenePicker.vtkScenePicker_GetEnableVertexPicking_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScenePicker_GetRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_GetRenderer_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkScenePicker_GetVertexId_06(HandleRef pThis, IntPtr displayPos);

		public long GetVertexId(IntPtr displayPos)
		{
			return vtkScenePicker.vtkScenePicker_GetVertexId_06(base.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScenePicker_GetViewProp_07(HandleRef pThis, IntPtr displayPos, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp GetViewProp(IntPtr displayPos)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_GetViewProp_07(base.GetCppThis(), displayPos, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScenePicker_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScenePicker.vtkScenePicker_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScenePicker_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScenePicker.vtkScenePicker_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScenePicker_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScenePicker NewInstance()
		{
			vtkScenePicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScenePicker_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScenePicker SafeDownCast(vtkObjectBase o)
		{
			vtkScenePicker vtkScenePicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScenePicker = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScenePicker.Register(null);
				}
			}
			return vtkScenePicker;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScenePicker_SetEnableVertexPicking_13(HandleRef pThis, int _arg);

		public virtual void SetEnableVertexPicking(int _arg)
		{
			vtkScenePicker.vtkScenePicker_SetEnableVertexPicking_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScenePicker_SetRenderer_14(HandleRef pThis, HandleRef arg0);

		public virtual void SetRenderer(vtkRenderer arg0)
		{
			vtkScenePicker.vtkScenePicker_SetRenderer_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
