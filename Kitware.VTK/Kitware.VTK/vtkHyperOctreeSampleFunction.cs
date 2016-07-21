using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeSampleFunction : vtkHyperOctreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeSampleFunction";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeSampleFunction()
		{
			vtkHyperOctreeSampleFunction.MRClassNameKey = "class vtkHyperOctreeSampleFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeSampleFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeSampleFunction"));
		}

		public vtkHyperOctreeSampleFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSampleFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeSampleFunction New()
		{
			vtkHyperOctreeSampleFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeSampleFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeSampleFunction_GetDepth_01(HandleRef pThis);

		public double GetDepth()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetDepth_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSampleFunction_GetDimension_02(HandleRef pThis);

		public int GetDimension()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetDimension_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeSampleFunction_GetHeight_03(HandleRef pThis);

		public double GetHeight()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetHeight_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSampleFunction_GetImplicitFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetImplicitFunction_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSampleFunction_GetLevels_05(HandleRef pThis);

		public int GetLevels()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetLevels_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkHyperOctreeSampleFunction_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSampleFunction_GetMinLevels_07(HandleRef pThis);

		public int GetMinLevels()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetMinLevels_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSampleFunction_GetOrigin_08(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetOrigin_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_GetOrigin_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetOrigin_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_GetOrigin_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetOrigin_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSampleFunction_GetOutputScalarType_11(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetOutputScalarType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSampleFunction_GetSize_12(HandleRef pThis);

		public virtual double[] GetSize()
		{
			IntPtr intPtr = vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetSize_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_GetSize_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSize(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetSize_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_GetSize_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetSize(IntPtr _arg)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetSize_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeSampleFunction_GetThreshold_15(HandleRef pThis);

		public double GetThreshold()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetThreshold_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHyperOctreeSampleFunction_GetWidth_16(HandleRef pThis);

		public double GetWidth()
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_GetWidth_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSampleFunction_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSampleFunction_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSampleFunction_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeSampleFunction NewInstance()
		{
			vtkHyperOctreeSampleFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSampleFunction_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeSampleFunction SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeSampleFunction vtkHyperOctreeSampleFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeSampleFunction = (vtkHyperOctreeSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeSampleFunction.Register(null);
				}
			}
			return vtkHyperOctreeSampleFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetDepth_22(HandleRef pThis, double depth);

		public void SetDepth(double depth)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetDepth_22(base.GetCppThis(), depth);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetDimension_23(HandleRef pThis, int dim);

		public void SetDimension(int dim)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetDimension_23(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetHeight_24(HandleRef pThis, double height);

		public void SetHeight(double height)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetHeight_24(base.GetCppThis(), height);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetImplicitFunction_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetImplicitFunction_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetLevels_26(HandleRef pThis, int levels);

		public void SetLevels(int levels)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetLevels_26(base.GetCppThis(), levels);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetMinLevels_27(HandleRef pThis, int minLevels);

		public void SetMinLevels(int minLevels)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetMinLevels_27(base.GetCppThis(), minLevels);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOrigin_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOrigin_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOrigin_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOrigin_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarType_30(HandleRef pThis, int _arg);

		public virtual void SetOutputScalarType(int _arg)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarType_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToChar_31(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToChar_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToDouble_32(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToDouble_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToFloat_33(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToFloat_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToInt_34(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToInt_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToLong_35(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToLong_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToShort_36(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToShort_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedChar_37(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedChar_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedInt_38(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedInt_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedLong_39(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedLong_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedShort_40(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetOutputScalarTypeToUnsignedShort_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetSize_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSize(double _arg1, double _arg2, double _arg3)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetSize_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetSize_42(HandleRef pThis, IntPtr _arg);

		public virtual void SetSize(IntPtr _arg)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetSize_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetThreshold_43(HandleRef pThis, double threshold);

		public void SetThreshold(double threshold)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetThreshold_43(base.GetCppThis(), threshold);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSampleFunction_SetWidth_44(HandleRef pThis, double width);

		public void SetWidth(double width)
		{
			vtkHyperOctreeSampleFunction.vtkHyperOctreeSampleFunction_SetWidth_44(base.GetCppThis(), width);
		}
	}
}
