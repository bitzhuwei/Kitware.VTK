using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextCodecFactory : vtkObject
	{
		public delegate IntPtr CreateFunction();

		public new const string MRFullTypeName = "Kitware.VTK.vtkTextCodecFactory";

		public new static readonly string MRClassNameKey;

		static vtkTextCodecFactory()
		{
			vtkTextCodecFactory.MRClassNameKey = "class vtkTextCodecFactory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextCodecFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextCodecFactory"));
		}

		public vtkTextCodecFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTextCodecFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextCodecFactory New()
		{
			vtkTextCodecFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextCodecFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextCodecFactory.vtkTextCodecFactory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTextCodecFactory_CodecForName_01(string CodecName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkTextCodec CodecForName(string CodecName)
		{
			vtkTextCodec vtkTextCodec = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_CodecForName_01(CodecName, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextCodec = (vtkTextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextCodec.Register(null);
				}
			}
			return vtkTextCodec;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTextCodecFactory_Initialize_02();

		public static void Initialize()
		{
			vtkTextCodecFactory.vtkTextCodecFactory_Initialize_02();
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTextCodecFactory_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextCodecFactory.vtkTextCodecFactory_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTextCodecFactory_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextCodecFactory.vtkTextCodecFactory_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTextCodecFactory_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextCodecFactory NewInstance()
		{
			vtkTextCodecFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTextCodecFactory_RegisterCreateCallback_07(vtkTextCodecFactory.CreateFunction callback);

		public static void RegisterCreateCallback(vtkTextCodecFactory.CreateFunction callback)
		{
			vtkTextCodecFactory.vtkTextCodecFactory_RegisterCreateCallback_07(callback);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTextCodecFactory_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextCodecFactory SafeDownCast(vtkObjectBase o)
		{
			vtkTextCodecFactory vtkTextCodecFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextCodecFactory = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextCodecFactory.Register(null);
				}
			}
			return vtkTextCodecFactory;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTextCodecFactory_UnRegisterAllCreateCallbacks_09();

		public static void UnRegisterAllCreateCallbacks()
		{
			vtkTextCodecFactory.vtkTextCodecFactory_UnRegisterAllCreateCallbacks_09();
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTextCodecFactory_UnRegisterCreateCallback_10(vtkTextCodecFactory.CreateFunction callback);

		public static void UnRegisterCreateCallback(vtkTextCodecFactory.CreateFunction callback)
		{
			vtkTextCodecFactory.vtkTextCodecFactory_UnRegisterCreateCallback_10(callback);
		}
	}
}
