using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeOrbitLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeOrbitLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkTreeOrbitLayoutStrategy()
		{
			vtkTreeOrbitLayoutStrategy.MRClassNameKey = "class vtkTreeOrbitLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeOrbitLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeOrbitLayoutStrategy"));
		}

		public vtkTreeOrbitLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeOrbitLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeOrbitLayoutStrategy New()
		{
			vtkTreeOrbitLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeOrbitLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetChildRadiusFactor_01(HandleRef pThis);

		public virtual double GetChildRadiusFactor()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetChildRadiusFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacing_02(HandleRef pThis);

		public virtual double GetLeafSpacing()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLeafSpacing_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacingMaxValue_03(HandleRef pThis);

		public virtual double GetLeafSpacingMaxValue()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLeafSpacingMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacingMinValue_04(HandleRef pThis);

		public virtual double GetLeafSpacingMinValue()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLeafSpacingMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLogSpacingValue_05(HandleRef pThis);

		public virtual double GetLogSpacingValue()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLogSpacingValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeOrbitLayoutStrategy_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeOrbitLayoutStrategy_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeOrbitLayoutStrategy_Layout_08(HandleRef pThis);

		public override void Layout()
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_Layout_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeOrbitLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeOrbitLayoutStrategy NewInstance()
		{
			vtkTreeOrbitLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeOrbitLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeOrbitLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkTreeOrbitLayoutStrategy vtkTreeOrbitLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeOrbitLayoutStrategy = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeOrbitLayoutStrategy.Register(null);
				}
			}
			return vtkTreeOrbitLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeOrbitLayoutStrategy_SetChildRadiusFactor_12(HandleRef pThis, double _arg);

		public virtual void SetChildRadiusFactor(double _arg)
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SetChildRadiusFactor_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeOrbitLayoutStrategy_SetLeafSpacing_13(HandleRef pThis, double _arg);

		public virtual void SetLeafSpacing(double _arg)
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SetLeafSpacing_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeOrbitLayoutStrategy_SetLogSpacingValue_14(HandleRef pThis, double _arg);

		public virtual void SetLogSpacingValue(double _arg)
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SetLogSpacingValue_14(base.GetCppThis(), _arg);
		}
	}
}
