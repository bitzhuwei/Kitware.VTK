using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkFunctionSet : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFunctionSet";

		public new static readonly string MRClassNameKey;

		static vtkFunctionSet()
		{
			vtkFunctionSet.MRClassNameKey = "class vtkFunctionSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFunctionSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFunctionSet"));
		}

		public vtkFunctionSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionSet_FunctionValues_01(HandleRef pThis, IntPtr x, IntPtr f);

		public virtual int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkFunctionSet.vtkFunctionSet_FunctionValues_01(base.GetCppThis(), x, f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionSet_GetNumberOfFunctions_02(HandleRef pThis);

		public virtual int GetNumberOfFunctions()
		{
			return vtkFunctionSet.vtkFunctionSet_GetNumberOfFunctions_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionSet_GetNumberOfIndependentVariables_03(HandleRef pThis);

		public virtual int GetNumberOfIndependentVariables()
		{
			return vtkFunctionSet.vtkFunctionSet_GetNumberOfIndependentVariables_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionSet_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFunctionSet.vtkFunctionSet_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionSet_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFunctionSet.vtkFunctionSet_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionSet_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFunctionSet NewInstance()
		{
			vtkFunctionSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFunctionSet.vtkFunctionSet_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionSet_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFunctionSet SafeDownCast(vtkObjectBase o)
		{
			vtkFunctionSet vtkFunctionSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFunctionSet.vtkFunctionSet_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionSet = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionSet.Register(null);
				}
			}
			return vtkFunctionSet;
		}
	}
}
