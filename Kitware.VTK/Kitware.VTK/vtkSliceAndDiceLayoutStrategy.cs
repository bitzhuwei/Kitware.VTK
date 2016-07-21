using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSliceAndDiceLayoutStrategy : vtkTreeMapLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliceAndDiceLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkSliceAndDiceLayoutStrategy()
		{
			vtkSliceAndDiceLayoutStrategy.MRClassNameKey = "class vtkSliceAndDiceLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliceAndDiceLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliceAndDiceLayoutStrategy"));
		}

		public vtkSliceAndDiceLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceAndDiceLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliceAndDiceLayoutStrategy New()
		{
			vtkSliceAndDiceLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceAndDiceLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSliceAndDiceLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSliceAndDiceLayoutStrategy_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSliceAndDiceLayoutStrategy_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSliceAndDiceLayoutStrategy_Layout_03(HandleRef pThis, HandleRef inputTree, HandleRef coordsArray, HandleRef sizeArray);

		public override void Layout(vtkTree inputTree, vtkDataArray coordsArray, vtkDataArray sizeArray)
		{
			vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_Layout_03(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (coordsArray == null) ? default(HandleRef) : coordsArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceAndDiceLayoutStrategy_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSliceAndDiceLayoutStrategy NewInstance()
		{
			vtkSliceAndDiceLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceAndDiceLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceAndDiceLayoutStrategy_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliceAndDiceLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSliceAndDiceLayoutStrategy vtkSliceAndDiceLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliceAndDiceLayoutStrategy.vtkSliceAndDiceLayoutStrategy_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliceAndDiceLayoutStrategy = (vtkSliceAndDiceLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliceAndDiceLayoutStrategy.Register(null);
				}
			}
			return vtkSliceAndDiceLayoutStrategy;
		}
	}
}
