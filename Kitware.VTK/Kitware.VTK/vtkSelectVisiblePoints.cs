using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSelectVisiblePoints : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectVisiblePoints";

		public new static readonly string MRClassNameKey;

		static vtkSelectVisiblePoints()
		{
			vtkSelectVisiblePoints.MRClassNameKey = "class vtkSelectVisiblePoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectVisiblePoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectVisiblePoints"));
		}

		public vtkSelectVisiblePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectVisiblePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectVisiblePoints New()
		{
			vtkSelectVisiblePoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSelectVisiblePoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSelectVisiblePoints.vtkSelectVisiblePoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkSelectVisiblePoints_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectVisiblePoints_GetRenderer_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetRenderer_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSelectVisiblePoints_GetSelectInvisible_03(HandleRef pThis);

		public virtual int GetSelectInvisible()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelectInvisible_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectVisiblePoints_GetSelection_04(HandleRef pThis);

		public virtual int[] GetSelection()
		{
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelection_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_GetSelection_05(HandleRef pThis, IntPtr data);

		public virtual void GetSelection(IntPtr data)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelection_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSelectVisiblePoints_GetSelectionWindow_06(HandleRef pThis);

		public virtual int GetSelectionWindow()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetSelectionWindow_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkSelectVisiblePoints_GetTolerance_07(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetTolerance_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkSelectVisiblePoints_GetToleranceMaxValue_08(HandleRef pThis);

		public virtual double GetToleranceMaxValue()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetToleranceMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkSelectVisiblePoints_GetToleranceMinValue_09(HandleRef pThis);

		public virtual double GetToleranceMinValue()
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_GetToleranceMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectVisiblePoints_Initialize_10(HandleRef pThis, byte getZbuff);

		public IntPtr Initialize(bool getZbuff)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_Initialize_10(base.GetCppThis(), getZbuff ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSelectVisiblePoints_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkSelectVisiblePoints_IsPointOccluded_12(HandleRef pThis, IntPtr x, IntPtr zPtr);

		public bool IsPointOccluded(IntPtr x, IntPtr zPtr)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_IsPointOccluded_12(base.GetCppThis(), x, zPtr) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSelectVisiblePoints_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSelectVisiblePoints.vtkSelectVisiblePoints_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectVisiblePoints_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSelectVisiblePoints NewInstance()
		{
			vtkSelectVisiblePoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectVisiblePoints_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectVisiblePoints SafeDownCast(vtkObjectBase o)
		{
			vtkSelectVisiblePoints vtkSelectVisiblePoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectVisiblePoints.vtkSelectVisiblePoints_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectVisiblePoints = (vtkSelectVisiblePoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectVisiblePoints.Register(null);
				}
			}
			return vtkSelectVisiblePoints;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SelectInvisibleOff_17(HandleRef pThis);

		public virtual void SelectInvisibleOff()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectInvisibleOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SelectInvisibleOn_18(HandleRef pThis);

		public virtual void SelectInvisibleOn()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectInvisibleOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SelectionWindowOff_19(HandleRef pThis);

		public virtual void SelectionWindowOff()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectionWindowOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SelectionWindowOn_20(HandleRef pThis);

		public virtual void SelectionWindowOn()
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SelectionWindowOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SetRenderer_21(HandleRef pThis, HandleRef ren);

		public void SetRenderer(vtkRenderer ren)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetRenderer_21(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SetSelectInvisible_22(HandleRef pThis, int _arg);

		public virtual void SetSelectInvisible(int _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelectInvisible_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SetSelection_23(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4);

		public virtual void SetSelection(int _arg1, int _arg2, int _arg3, int _arg4)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelection_23(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SetSelection_24(HandleRef pThis, IntPtr _arg);

		public virtual void SetSelection(IntPtr _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelection_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SetSelectionWindow_25(HandleRef pThis, int _arg);

		public virtual void SetSelectionWindow(int _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetSelectionWindow_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSelectVisiblePoints_SetTolerance_26(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkSelectVisiblePoints.vtkSelectVisiblePoints_SetTolerance_26(base.GetCppThis(), _arg);
		}
	}
}
