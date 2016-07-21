using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitBoolean : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitBoolean";

		public new static readonly string MRClassNameKey;

		static vtkImplicitBoolean()
		{
			vtkImplicitBoolean.MRClassNameKey = "class vtkImplicitBoolean";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitBoolean.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitBoolean"));
		}

		public vtkImplicitBoolean(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitBoolean_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitBoolean New()
		{
			vtkImplicitBoolean result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitBoolean() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitBoolean.vtkImplicitBoolean_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_AddFunction_01(HandleRef pThis, HandleRef arg0);

		public void AddFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_AddFunction_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitBoolean_EvaluateFunction_02(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_EvaluateFunction_02(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitBoolean_EvaluateFunction_03(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_EvaluateFunction_03(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr g);

		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_EvaluateGradient_04(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitBoolean_GetFunction_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImplicitFunctionCollection GetFunction()
		{
			vtkImplicitFunctionCollection vtkImplicitFunctionCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_GetFunction_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunctionCollection = (vtkImplicitFunctionCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunctionCollection.Register(null);
				}
			}
			return vtkImplicitFunctionCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImplicitBoolean_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitBoolean_GetOperationType_07(HandleRef pThis);

		public virtual int GetOperationType()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetOperationType_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitBoolean_GetOperationTypeAsString_08(HandleRef pThis);

		public string GetOperationTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImplicitBoolean.vtkImplicitBoolean_GetOperationTypeAsString_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitBoolean_GetOperationTypeMaxValue_09(HandleRef pThis);

		public virtual int GetOperationTypeMaxValue()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetOperationTypeMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitBoolean_GetOperationTypeMinValue_10(HandleRef pThis);

		public virtual int GetOperationTypeMinValue()
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_GetOperationTypeMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitBoolean_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitBoolean_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitBoolean.vtkImplicitBoolean_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitBoolean_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitBoolean NewInstance()
		{
			vtkImplicitBoolean result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_RemoveFunction_15(HandleRef pThis, HandleRef arg0);

		public void RemoveFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_RemoveFunction_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitBoolean_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitBoolean SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitBoolean vtkImplicitBoolean = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitBoolean.vtkImplicitBoolean_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitBoolean = (vtkImplicitBoolean)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitBoolean.Register(null);
				}
			}
			return vtkImplicitBoolean;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_SetOperationType_17(HandleRef pThis, int _arg);

		public virtual void SetOperationType(int _arg)
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationType_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToDifference_18(HandleRef pThis);

		public void SetOperationTypeToDifference()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToDifference_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToIntersection_19(HandleRef pThis);

		public void SetOperationTypeToIntersection()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToIntersection_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToUnion_20(HandleRef pThis);

		public void SetOperationTypeToUnion()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToUnion_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitBoolean_SetOperationTypeToUnionOfMagnitudes_21(HandleRef pThis);

		public void SetOperationTypeToUnionOfMagnitudes()
		{
			vtkImplicitBoolean.vtkImplicitBoolean_SetOperationTypeToUnionOfMagnitudes_21(base.GetCppThis());
		}
	}
}
