using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBoxLayoutStrategy : vtkTreeMapLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkBoxLayoutStrategy()
		{
			vtkBoxLayoutStrategy.MRClassNameKey = "class vtkBoxLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxLayoutStrategy"));
		}

		public vtkBoxLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxLayoutStrategy New()
		{
			vtkBoxLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBoxLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBoxLayoutStrategy_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBoxLayoutStrategy_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBoxLayoutStrategy_Layout_03(HandleRef pThis, HandleRef inputTree, HandleRef coordsArray, HandleRef sizeArray);

		public override void Layout(vtkTree inputTree, vtkDataArray coordsArray, vtkDataArray sizeArray)
		{
			vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_Layout_03(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (coordsArray == null) ? default(HandleRef) : coordsArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxLayoutStrategy_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBoxLayoutStrategy NewInstance()
		{
			vtkBoxLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxLayoutStrategy_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkBoxLayoutStrategy vtkBoxLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxLayoutStrategy.vtkBoxLayoutStrategy_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxLayoutStrategy = (vtkBoxLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxLayoutStrategy.Register(null);
				}
			}
			return vtkBoxLayoutStrategy;
		}
	}
}
