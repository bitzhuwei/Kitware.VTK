using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadratureSchemeDictionaryGenerator : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadratureSchemeDictionaryGenerator";

		public new static readonly string MRClassNameKey;

		static vtkQuadratureSchemeDictionaryGenerator()
		{
			vtkQuadratureSchemeDictionaryGenerator.MRClassNameKey = "class vtkQuadratureSchemeDictionaryGenerator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadratureSchemeDictionaryGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadratureSchemeDictionaryGenerator"));
		}

		public vtkQuadratureSchemeDictionaryGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDictionaryGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadratureSchemeDictionaryGenerator New()
		{
			vtkQuadratureSchemeDictionaryGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDictionaryGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadratureSchemeDictionaryGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDictionaryGenerator_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDictionaryGenerator_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDictionaryGenerator_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadratureSchemeDictionaryGenerator NewInstance()
		{
			vtkQuadratureSchemeDictionaryGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDictionaryGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDictionaryGenerator_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadratureSchemeDictionaryGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkQuadratureSchemeDictionaryGenerator vtkQuadratureSchemeDictionaryGenerator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDictionaryGenerator.vtkQuadratureSchemeDictionaryGenerator_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadratureSchemeDictionaryGenerator = (vtkQuadratureSchemeDictionaryGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadratureSchemeDictionaryGenerator.Register(null);
				}
			}
			return vtkQuadratureSchemeDictionaryGenerator;
		}
	}
}
