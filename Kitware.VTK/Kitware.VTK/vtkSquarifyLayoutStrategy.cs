using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSquarifyLayoutStrategy : vtkTreeMapLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSquarifyLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkSquarifyLayoutStrategy()
		{
			vtkSquarifyLayoutStrategy.MRClassNameKey = "class vtkSquarifyLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSquarifyLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSquarifyLayoutStrategy"));
		}

		public vtkSquarifyLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSquarifyLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSquarifyLayoutStrategy New()
		{
			vtkSquarifyLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSquarifyLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSquarifyLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSquarifyLayoutStrategy_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSquarifyLayoutStrategy_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSquarifyLayoutStrategy_Layout_03(HandleRef pThis, HandleRef inputTree, HandleRef coordsArray, HandleRef sizeArray);

		public override void Layout(vtkTree inputTree, vtkDataArray coordsArray, vtkDataArray sizeArray)
		{
			vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_Layout_03(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (coordsArray == null) ? default(HandleRef) : coordsArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSquarifyLayoutStrategy_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSquarifyLayoutStrategy NewInstance()
		{
			vtkSquarifyLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSquarifyLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSquarifyLayoutStrategy_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSquarifyLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSquarifyLayoutStrategy vtkSquarifyLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSquarifyLayoutStrategy.vtkSquarifyLayoutStrategy_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSquarifyLayoutStrategy = (vtkSquarifyLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSquarifyLayoutStrategy.Register(null);
				}
			}
			return vtkSquarifyLayoutStrategy;
		}
	}
}
