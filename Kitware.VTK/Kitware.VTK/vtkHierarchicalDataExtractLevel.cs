using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalDataExtractLevel : vtkExtractLevel
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataExtractLevel";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalDataExtractLevel()
		{
			vtkHierarchicalDataExtractLevel.MRClassNameKey = "class vtkHierarchicalDataExtractLevel";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataExtractLevel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataExtractLevel"));
		}

		public vtkHierarchicalDataExtractLevel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataExtractLevel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataExtractLevel New()
		{
			vtkHierarchicalDataExtractLevel result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractLevel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalDataExtractLevel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataExtractLevel_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataExtractLevel_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataExtractLevel_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalDataExtractLevel NewInstance()
		{
			vtkHierarchicalDataExtractLevel result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractLevel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataExtractLevel_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataExtractLevel SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataExtractLevel vtkHierarchicalDataExtractLevel = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataExtractLevel.vtkHierarchicalDataExtractLevel_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataExtractLevel = (vtkHierarchicalDataExtractLevel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataExtractLevel.Register(null);
				}
			}
			return vtkHierarchicalDataExtractLevel;
		}
	}
}
