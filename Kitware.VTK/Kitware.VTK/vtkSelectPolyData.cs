using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSelectPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectPolyData";

		public new static readonly string MRClassNameKey;

		static vtkSelectPolyData()
		{
			vtkSelectPolyData.MRClassNameKey = "class vtkSelectPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectPolyData"));
		}

		public vtkSelectPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectPolyData New()
		{
			vtkSelectPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSelectPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSelectPolyData.vtkSelectPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_GenerateSelectionScalarsOff_01(HandleRef pThis);

		public virtual void GenerateSelectionScalarsOff()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateSelectionScalarsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_GenerateSelectionScalarsOn_02(HandleRef pThis);

		public virtual void GenerateSelectionScalarsOn()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateSelectionScalarsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_GenerateUnselectedOutputOff_03(HandleRef pThis);

		public virtual void GenerateUnselectedOutputOff()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateUnselectedOutputOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_GenerateUnselectedOutputOn_04(HandleRef pThis);

		public virtual void GenerateUnselectedOutputOn()
		{
			vtkSelectPolyData.vtkSelectPolyData_GenerateUnselectedOutputOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_GetGenerateSelectionScalars_05(HandleRef pThis);

		public virtual int GetGenerateSelectionScalars()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetGenerateSelectionScalars_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_GetGenerateUnselectedOutput_06(HandleRef pThis);

		public virtual int GetGenerateUnselectedOutput()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetGenerateUnselectedOutput_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_GetInsideOut_07(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetInsideOut_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectPolyData_GetLoop_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetLoop()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetLoop_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkSelectPolyData_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectPolyData_GetSelectionEdges_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSelectionEdges()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetSelectionEdges_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_GetSelectionMode_11(HandleRef pThis);

		public virtual int GetSelectionMode()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetSelectionMode_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectPolyData_GetSelectionModeAsString_12(HandleRef pThis);

		public string GetSelectionModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkSelectPolyData.vtkSelectPolyData_GetSelectionModeAsString_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_GetSelectionModeMaxValue_13(HandleRef pThis);

		public virtual int GetSelectionModeMaxValue()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetSelectionModeMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_GetSelectionModeMinValue_14(HandleRef pThis);

		public virtual int GetSelectionModeMinValue()
		{
			return vtkSelectPolyData.vtkSelectPolyData_GetSelectionModeMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectPolyData_GetUnselectedOutput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetUnselectedOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_GetUnselectedOutput_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_InsideOutOff_16(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkSelectPolyData.vtkSelectPolyData_InsideOutOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_InsideOutOn_17(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkSelectPolyData.vtkSelectPolyData_InsideOutOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSelectPolyData.vtkSelectPolyData_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectPolyData_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSelectPolyData.vtkSelectPolyData_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectPolyData_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSelectPolyData NewInstance()
		{
			vtkSelectPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectPolyData_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkSelectPolyData vtkSelectPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectPolyData.vtkSelectPolyData_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectPolyData = (vtkSelectPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectPolyData.Register(null);
				}
			}
			return vtkSelectPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetGenerateSelectionScalars_23(HandleRef pThis, int _arg);

		public virtual void SetGenerateSelectionScalars(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetGenerateSelectionScalars_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetGenerateUnselectedOutput_24(HandleRef pThis, int _arg);

		public virtual void SetGenerateUnselectedOutput(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetGenerateUnselectedOutput_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetInsideOut_25(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetInsideOut_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetLoop_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetLoop(vtkPoints arg0)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetLoop_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetSelectionMode_27(HandleRef pThis, int _arg);

		public virtual void SetSelectionMode(int _arg)
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionMode_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetSelectionModeToClosestPointRegion_28(HandleRef pThis);

		public void SetSelectionModeToClosestPointRegion()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionModeToClosestPointRegion_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetSelectionModeToLargestRegion_29(HandleRef pThis);

		public void SetSelectionModeToLargestRegion()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionModeToLargestRegion_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectPolyData_SetSelectionModeToSmallestRegion_30(HandleRef pThis);

		public void SetSelectionModeToSmallestRegion()
		{
			vtkSelectPolyData.vtkSelectPolyData_SetSelectionModeToSmallestRegion_30(base.GetCppThis());
		}
	}
}
