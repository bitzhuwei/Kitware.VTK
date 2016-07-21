using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkTreeLayoutStrategy()
		{
			vtkTreeLayoutStrategy.MRClassNameKey = "class vtkTreeLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeLayoutStrategy"));
		}

		public vtkTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeLayoutStrategy New()
		{
			vtkTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetAngle_01(HandleRef pThis);

		public virtual double GetAngle()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetAngle_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetAngleMaxValue_02(HandleRef pThis);

		public virtual double GetAngleMaxValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetAngleMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetAngleMinValue_03(HandleRef pThis);

		public virtual double GetAngleMinValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetAngleMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeLayoutStrategy_GetDistanceArrayName_04(HandleRef pThis);

		public virtual string GetDistanceArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetDistanceArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetLeafSpacing_05(HandleRef pThis);

		public virtual double GetLeafSpacing()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLeafSpacing_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetLeafSpacingMaxValue_06(HandleRef pThis);

		public virtual double GetLeafSpacingMaxValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLeafSpacingMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetLeafSpacingMinValue_07(HandleRef pThis);

		public virtual double GetLeafSpacingMinValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLeafSpacingMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetLogSpacingValue_08(HandleRef pThis);

		public virtual double GetLogSpacingValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLogSpacingValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkTreeLayoutStrategy_GetRadial_09(HandleRef pThis);

		public virtual bool GetRadial()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetRadial_09(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkTreeLayoutStrategy_GetReverseEdges_10(HandleRef pThis);

		public virtual bool GetReverseEdges()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetReverseEdges_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeLayoutStrategy_GetRotation_11(HandleRef pThis);

		public virtual double GetRotation()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetRotation_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeLayoutStrategy_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeLayoutStrategy_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_Layout_14(HandleRef pThis);

		public override void Layout()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_Layout_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeLayoutStrategy_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeLayoutStrategy NewInstance()
		{
			vtkTreeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_RadialOff_17(HandleRef pThis);

		public virtual void RadialOff()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_RadialOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_RadialOn_18(HandleRef pThis);

		public virtual void RadialOn()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_RadialOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_ReverseEdgesOff_19(HandleRef pThis);

		public virtual void ReverseEdgesOff()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_ReverseEdgesOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_ReverseEdgesOn_20(HandleRef pThis);

		public virtual void ReverseEdgesOn()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_ReverseEdgesOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeLayoutStrategy_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkTreeLayoutStrategy vtkTreeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeLayoutStrategy = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeLayoutStrategy.Register(null);
				}
			}
			return vtkTreeLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_SetAngle_22(HandleRef pThis, double _arg);

		public virtual void SetAngle(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetAngle_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_SetDistanceArrayName_23(HandleRef pThis, string _arg);

		public virtual void SetDistanceArrayName(string _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetDistanceArrayName_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_SetLeafSpacing_24(HandleRef pThis, double _arg);

		public virtual void SetLeafSpacing(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetLeafSpacing_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_SetLogSpacingValue_25(HandleRef pThis, double _arg);

		public virtual void SetLogSpacingValue(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetLogSpacingValue_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_SetRadial_26(HandleRef pThis, byte _arg);

		public virtual void SetRadial(bool _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetRadial_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_SetReverseEdges_27(HandleRef pThis, byte _arg);

		public virtual void SetReverseEdges(bool _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetReverseEdges_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeLayoutStrategy_SetRotation_28(HandleRef pThis, double _arg);

		public virtual void SetRotation(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetRotation_28(base.GetCppThis(), _arg);
		}
	}
}
