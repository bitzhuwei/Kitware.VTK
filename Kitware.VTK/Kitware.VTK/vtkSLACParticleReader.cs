using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSLACParticleReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSLACParticleReader";

		public new static readonly string MRClassNameKey;

		static vtkSLACParticleReader()
		{
			vtkSLACParticleReader.MRClassNameKey = "class vtkSLACParticleReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSLACParticleReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLACParticleReader"));
		}

		public vtkSLACParticleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACParticleReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSLACParticleReader New()
		{
			vtkSLACParticleReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACParticleReader.vtkSLACParticleReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSLACParticleReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSLACParticleReader.vtkSLACParticleReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACParticleReader_CanReadFile_01(string filename);

		public static int CanReadFile(string filename)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_CanReadFile_01(filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACParticleReader_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSLACParticleReader.vtkSLACParticleReader_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACParticleReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACParticleReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACParticleReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSLACParticleReader NewInstance()
		{
			vtkSLACParticleReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACParticleReader.vtkSLACParticleReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACParticleReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSLACParticleReader SafeDownCast(vtkObjectBase o)
		{
			vtkSLACParticleReader vtkSLACParticleReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACParticleReader.vtkSLACParticleReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSLACParticleReader = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSLACParticleReader.Register(null);
				}
			}
			return vtkSLACParticleReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACParticleReader_SetFileName_08(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkSLACParticleReader.vtkSLACParticleReader_SetFileName_08(base.GetCppThis(), _arg);
		}
	}
}
