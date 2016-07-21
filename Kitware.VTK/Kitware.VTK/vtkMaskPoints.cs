using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMaskPoints : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMaskPoints";

		public new static readonly string MRClassNameKey;

		static vtkMaskPoints()
		{
			vtkMaskPoints.MRClassNameKey = "class vtkMaskPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaskPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskPoints"));
		}

		public vtkMaskPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaskPoints New()
		{
			vtkMaskPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskPoints.vtkMaskPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMaskPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMaskPoints.vtkMaskPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_GenerateVerticesOff_01(HandleRef pThis);

		public virtual void GenerateVerticesOff()
		{
			vtkMaskPoints.vtkMaskPoints_GenerateVerticesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_GenerateVerticesOn_02(HandleRef pThis);

		public virtual void GenerateVerticesOn()
		{
			vtkMaskPoints.vtkMaskPoints_GenerateVerticesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_GetGenerateVertices_03(HandleRef pThis);

		public virtual int GetGenerateVertices()
		{
			return vtkMaskPoints.vtkMaskPoints_GetGenerateVertices_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPoints_GetMaximumNumberOfPoints_04(HandleRef pThis);

		public virtual long GetMaximumNumberOfPoints()
		{
			return vtkMaskPoints.vtkMaskPoints_GetMaximumNumberOfPoints_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPoints_GetMaximumNumberOfPointsMaxValue_05(HandleRef pThis);

		public virtual long GetMaximumNumberOfPointsMaxValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetMaximumNumberOfPointsMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPoints_GetMaximumNumberOfPointsMinValue_06(HandleRef pThis);

		public virtual long GetMaximumNumberOfPointsMinValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetMaximumNumberOfPointsMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPoints_GetOffset_07(HandleRef pThis);

		public virtual long GetOffset()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOffset_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPoints_GetOffsetMaxValue_08(HandleRef pThis);

		public virtual long GetOffsetMaxValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOffsetMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPoints_GetOffsetMinValue_09(HandleRef pThis);

		public virtual long GetOffsetMinValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOffsetMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_GetOnRatio_10(HandleRef pThis);

		public virtual int GetOnRatio()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOnRatio_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_GetOnRatioMaxValue_11(HandleRef pThis);

		public virtual int GetOnRatioMaxValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOnRatioMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_GetOnRatioMinValue_12(HandleRef pThis);

		public virtual int GetOnRatioMinValue()
		{
			return vtkMaskPoints.vtkMaskPoints_GetOnRatioMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_GetRandomMode_13(HandleRef pThis);

		public virtual int GetRandomMode()
		{
			return vtkMaskPoints.vtkMaskPoints_GetRandomMode_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_GetSingleVertexPerCell_14(HandleRef pThis);

		public virtual int GetSingleVertexPerCell()
		{
			return vtkMaskPoints.vtkMaskPoints_GetSingleVertexPerCell_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMaskPoints.vtkMaskPoints_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPoints_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMaskPoints.vtkMaskPoints_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskPoints_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMaskPoints NewInstance()
		{
			vtkMaskPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskPoints.vtkMaskPoints_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_RandomModeOff_19(HandleRef pThis);

		public virtual void RandomModeOff()
		{
			vtkMaskPoints.vtkMaskPoints_RandomModeOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_RandomModeOn_20(HandleRef pThis);

		public virtual void RandomModeOn()
		{
			vtkMaskPoints.vtkMaskPoints_RandomModeOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskPoints_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaskPoints SafeDownCast(vtkObjectBase o)
		{
			vtkMaskPoints vtkMaskPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskPoints.vtkMaskPoints_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaskPoints = (vtkMaskPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaskPoints.Register(null);
				}
			}
			return vtkMaskPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SetGenerateVertices_22(HandleRef pThis, int _arg);

		public virtual void SetGenerateVertices(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetGenerateVertices_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SetMaximumNumberOfPoints_23(HandleRef pThis, long _arg);

		public virtual void SetMaximumNumberOfPoints(long _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetMaximumNumberOfPoints_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SetOffset_24(HandleRef pThis, long _arg);

		public virtual void SetOffset(long _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetOffset_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SetOnRatio_25(HandleRef pThis, int _arg);

		public virtual void SetOnRatio(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetOnRatio_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SetRandomMode_26(HandleRef pThis, int _arg);

		public virtual void SetRandomMode(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetRandomMode_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SetSingleVertexPerCell_27(HandleRef pThis, int _arg);

		public virtual void SetSingleVertexPerCell(int _arg)
		{
			vtkMaskPoints.vtkMaskPoints_SetSingleVertexPerCell_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SingleVertexPerCellOff_28(HandleRef pThis);

		public virtual void SingleVertexPerCellOff()
		{
			vtkMaskPoints.vtkMaskPoints_SingleVertexPerCellOff_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPoints_SingleVertexPerCellOn_29(HandleRef pThis);

		public virtual void SingleVertexPerCellOn()
		{
			vtkMaskPoints.vtkMaskPoints_SingleVertexPerCellOn_29(base.GetCppThis());
		}
	}
}
