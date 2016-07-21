using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleTerrain : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTerrain";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleTerrain()
		{
			vtkInteractorStyleTerrain.MRClassNameKey = "class vtkInteractorStyleTerrain";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTerrain.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTerrain"));
		}

		public vtkInteractorStyleTerrain(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTerrain_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTerrain New()
		{
			vtkInteractorStyleTerrain result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleTerrain() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_Dolly_01(HandleRef pThis);

		public override void Dolly()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_Dolly_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTerrain_GetLatLongLines_02(HandleRef pThis);

		public virtual int GetLatLongLines()
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_GetLatLongLines_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTerrain_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleTerrain_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_LatLongLinesOff_05(HandleRef pThis);

		public virtual void LatLongLinesOff()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_LatLongLinesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_LatLongLinesOn_06(HandleRef pThis);

		public virtual void LatLongLinesOn()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_LatLongLinesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTerrain_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleTerrain NewInstance()
		{
			vtkInteractorStyleTerrain result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnChar_09(HandleRef pThis);

		public override void OnChar()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnChar_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnLeftButtonDown_10(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnLeftButtonDown_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnLeftButtonUp_11(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnLeftButtonUp_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnMiddleButtonDown_12(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnMiddleButtonDown_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnMiddleButtonUp_13(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnMiddleButtonUp_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnMouseMove_14(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnMouseMove_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnRightButtonDown_15(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnRightButtonDown_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_OnRightButtonUp_16(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_OnRightButtonUp_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_Pan_17(HandleRef pThis);

		public override void Pan()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_Pan_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_Rotate_18(HandleRef pThis);

		public override void Rotate()
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_Rotate_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleTerrain_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleTerrain SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTerrain vtkInteractorStyleTerrain = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTerrain = (vtkInteractorStyleTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTerrain.Register(null);
				}
			}
			return vtkInteractorStyleTerrain;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleTerrain_SetLatLongLines_20(HandleRef pThis, int _arg);

		public virtual void SetLatLongLines(int _arg)
		{
			vtkInteractorStyleTerrain.vtkInteractorStyleTerrain_SetLatLongLines_20(base.GetCppThis(), _arg);
		}
	}
}
